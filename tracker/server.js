const express = require('express');
const fs = require('fs');
const path = require('path');

const app = express();
const PORT = 3150;
const DB_FILE = path.join(__dirname, 'progress.json');

app.use(express.json());

// Serve the HTML tracker
app.get('/', (req, res) => {
    res.sendFile(path.join(__dirname, 'index.html'));
});

// GET progress data
app.get('/api/progress', (req, res) => {
    try {
        const data = fs.existsSync(DB_FILE)
            ? JSON.parse(fs.readFileSync(DB_FILE, 'utf-8'))
            : { progress: {}, revision: {} };
        res.json(data);
    } catch (err) {
        res.json({ progress: {}, revision: {} });
    }
});

// SAVE progress data
app.post('/api/progress', (req, res) => {
    try {
        fs.writeFileSync(DB_FILE, JSON.stringify(req.body, null, 2));
        res.json({ ok: true });
    } catch (err) {
        res.status(500).json({ error: err.message });
    }
});

app.listen(PORT, () => {
    console.log(`\n  🎯 NeetCode Tracker running at http://localhost:${PORT}\n`);
});
