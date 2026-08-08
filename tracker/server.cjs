const express = require('express');
const fs = require('fs');
const path = require('path');

const app = express();
const PORT = 3150;
const DB_FILE = path.join(__dirname, 'progress.json');
const DIST_DIR = path.join(__dirname, 'dist');

app.use(express.json());

// API: GET progress data
app.get('/api/progress', (req, res) => {
    try {
        const data = fs.existsSync(DB_FILE)
            ? JSON.parse(fs.readFileSync(DB_FILE, 'utf-8'))
            : { progress: {}, revision: {}, revision_v2: { redos: {}, mock_history: [] }, sd_progress: {}, sm_progress: {} };
        res.json(data);
    } catch (err) {
        res.json({ progress: {}, revision: {}, revision_v2: { redos: {}, mock_history: [] }, sd_progress: {}, sm_progress: {} });
    }
});

// API: SAVE progress data
app.post('/api/progress', (req, res) => {
    try {
        fs.writeFileSync(DB_FILE, JSON.stringify(req.body, null, 2));
        res.json({ ok: true });
    } catch (err) {
        res.status(500).json({ error: err.message });
    }
});

// Serve the React app build (if dist exists) or fall back to legacy
if (fs.existsSync(DIST_DIR)) {
    app.use(express.static(DIST_DIR));
    // SPA fallback: serve index.html for all non-API routes
    app.get('*', (req, res) => {
        res.sendFile(path.join(DIST_DIR, 'index.html'));
    });
} else {
    // Fallback to legacy single-file tracker
    app.get('/', (req, res) => {
        const legacy = path.join(__dirname, 'index-legacy.html');
        if (fs.existsSync(legacy)) {
            res.sendFile(legacy);
        } else {
            res.sendFile(path.join(__dirname, 'index.html'));
        }
    });
}

app.listen(PORT, () => {
    console.log(`\n  🎯 DSA Tracker running at http://localhost:${PORT}\n`);
});
