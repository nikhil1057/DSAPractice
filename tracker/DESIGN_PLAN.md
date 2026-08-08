# NeetCode Tracker — Production UI/UX Redesign Plan

> Combining EasyRoadmaps neobrutalist design language, UI UX Pro Max intelligence, and Anthropic frontend-design principles.

---

## 1. Design Philosophy

### The Brief (Anthropic frontend-design)

**Subject:** A personal DSA + System Design + Stack Mastery tracker for a software engineer preparing for interviews.

**Audience:** One person (you) — a developer who needs clarity on what to do TODAY, what's falling behind, and where momentum is building.

**Page's single job:** Answer "What should I work on right now?" within 2 seconds of landing.

**The thesis (hero):** Your progress is a living journey, not a checklist. The most characteristic thing in this world is the *path* — the candy-trail of topics flowing from solved → in-progress → upcoming. Open with that.

**Signature element:** The **Candy Path Timeline** from EasyRoadmaps — adapted as a vertical progress spine showing today's position in your 48-day journey. One bold visual element; everything else stays quiet.

**Restraint check:** No GitHub-style heatmap (templated). No donut charts (decoration). No numbered 01/02/03 markers (the content isn't a sequence of equal steps — it's a flowing journey with varying difficulty and category).

---

## 2. Design System (Tokens)

### Style Classification (UI UX Pro Max)

| Axis | Choice | Reasoning |
|------|--------|-----------|
| Primary Style | **#20 Neubrutalism** | Matches EasyRoadmaps DNA — bold borders, pop shadows, playful but functional |
| Dashboard Style | **#3 Executive Dashboard** | Clean stat cards, progress indicators, minimal noise |
| Layout Pattern | **Bento Grid** (#21) | Multi-track content (DSA/SD/SM) organized in asymmetric grid cells |
| Anti-patterns | No glassmorphism, no gradients-as-decoration, no AI purple/pink defaults |

### Color Palette

```css
:root {
  /* Backgrounds */
  --bg:            #fffdf5;    /* Warm cream (EasyRoadmaps) */
  --bg-deep:       #fff7df;    /* Deeper cream for sections */
  --surface:       #ffffff;    /* Card surfaces */

  /* Text */
  --text:          #1e293b;    /* Slate 800 — primary */
  --text-muted:    #475569;    /* Slate 600 */
  --text-subtle:   #64748b;    /* Slate 500 */

  /* Accent — one primary, used sparingly */
  --accent:        #8b5cf6;    /* Violet 500 — the "brand" */
  --accent-dark:   #6d28d9;    /* Violet 700 */
  --accent-soft:   rgba(139, 92, 246, 0.16);

  /* Semantic — progress states */
  --solved:        #059669;    /* Emerald 600 */
  --solved-soft:   rgba(52, 211, 153, 0.18);
  --in-progress:   #f59e0b;    /* Amber 500 */
  --in-progress-soft: rgba(251, 191, 36, 0.22);
  --overdue:       #dc2626;    /* Red 600 */
  --overdue-soft:  rgba(248, 113, 113, 0.14);

  /* Track colors */
  --track-dsa:     #8b5cf6;    /* Violet */
  --track-sd:      #10b981;    /* Emerald */
  --track-sm:      #f59e0b;    /* Amber */

  /* Structural */
  --border:        #1e293b;    /* Hard border — neobrutalist signature */
  --border-light:  #e2e8f0;    /* Subtle dividers */
  --radius:        1.5rem;     /* 24px — rounded but not circular */
  --radius-sm:     1rem;       /* 16px for small cards */
  --radius-pill:   999px;      /* Pills and badges */

  /* Shadows — the "pop" */
  --shadow-card:   4px 4px 0 0 #e2e8f0;
  --shadow-pop:    4px 4px 0 0 var(--border);
  --shadow-pop-hover: 6px 6px 0 0 var(--border);
  --shadow-active: 2px 2px 0 0 var(--border);
  --shadow-violet: 6px 6px 0 0 #ddd6fe;
  --shadow-amber:  6px 6px 0 0 #fde68a;
  --shadow-mint:   6px 6px 0 0 #bbf7d0;

  /* Motion */
  --ease-pop:      cubic-bezier(0.34, 1.56, 0.64, 1);
  --duration-fast: 150ms;
  --duration-med:  220ms;
  --duration-slow: 320ms;
}
```

### Typography

```css
/* Display: characterful, used with restraint */
font-family: "Outfit", system-ui, sans-serif;
/* Headings, stats, hero numbers only */

/* Body: complementary, highly readable */
font-family: "Plus Jakarta Sans", system-ui, sans-serif;
/* All body text, labels, nav */

/* Utility: monospace for data */
font-family: "JetBrains Mono", "SF Mono", monospace;
/* Time stamps, code refs, day counters */
```

**Type Scale:**
| Role | Size | Weight | Face |
|------|------|--------|------|
| Hero stat | clamp(2.5rem, 5vw, 4rem) | 800 | Outfit |
| Page title | 1.75rem | 700 | Outfit |
| Section heading | 1.15rem | 700 | Plus Jakarta Sans |
| Body | 0.95rem | 400 | Plus Jakarta Sans |
| Caption/label | 0.75rem | 700 | Plus Jakarta Sans |
| Data/mono | 0.82rem | 500 | JetBrains Mono |

### Component Library

| Component | Style |
|-----------|-------|
| Card | 2px solid border, var(--radius), var(--shadow-card), white bg |
| Button Primary | 2px border, pill radius, accent bg, white text, shadow-pop, translate on hover |
| Button Secondary | 2px border, pill radius, white bg, shadow-card, amber bg on hover |
| Badge/Pill | 2px border, pill radius, semantic bg color, uppercase 0.7rem |
| Progress Track | 0.85rem height, 2px border, pill radius, gradient fill |
| Checkbox | 1.5rem square, 2px border, rounded-md, emerald when checked, checkmark SVG |
| Nav Link | Pill-shaped, 2px border, shadow on active, amber on hover |
| Toast | Fixed bottom-center, pill radius, colored bg, slide-up animation |

---

## 3. Architecture

### Tech Stack Migration

| Current | New |
|---------|-----|
| Single 113KB HTML file | React 19 + Vite 8 + TypeScript |
| Inline CSS | Tailwind CSS v4 + CSS custom properties |
| Vanilla JS | Component-based with React Router |
| No icons library | Lucide React (SVG icons) |
| No state management | React Context + useReducer |
| Express server | Keep Express API (unchanged) |

### File Structure

```
tracker/
├── server.js                      ← Keep unchanged (API)
├── progress.json                  ← Keep unchanged (data)
├── package.json                   ← Add React/Vite/Tailwind deps
├── vite.config.ts
├── tailwind.config.js
├── tsconfig.json
├── index.html                     ← Vite entry (thin shell)
├── src/
│   ├── main.tsx                   ← React entry
│   ├── App.tsx                    ← Router + Shell
│   ├── index.css                  ← Design tokens + global styles
│   ├── api/
│   │   └── progress.ts           ← fetch/save helpers
│   ├── state/
│   │   ├── ProgressContext.tsx    ← Global state provider
│   │   └── types.ts              ← TypeScript interfaces
│   ├── data/
│   │   ├── neetcode-plan.ts      ← DSA schedule (moved from inline)
│   │   ├── sd-plan.ts            ← System Design schedule
│   │   ├── sm-plan.ts            ← Stack Mastery schedule
│   │   └── leetcode-urls.ts      ← URL map
│   ├── components/
│   │   ├── Shell.tsx             ← Layout: sidebar + main
│   │   ├── Sidebar.tsx           ← Navigation + mini progress
│   │   ├── DayStrip.tsx          ← This-week calendar strip
│   │   ├── ProgressRing.tsx      ← Circular progress indicator
│   │   ├── StatCard.tsx          ← Metric card (neobrutalist)
│   │   ├── ProblemRow.tsx        ← Checkbox + name + tags
│   │   ├── CandyPath.tsx         ← Timeline spine (signature)
│   │   ├── CategoryPill.tsx      ← Colored pill badge
│   │   ├── RedoCard.tsx          ← Revision queue item
│   │   ├── WeekAccordion.tsx     ← Collapsible week section
│   │   ├── PatternHealthGrid.tsx ← Category freshness
│   │   └── Toast.tsx             ← Notification
│   └── pages/
│       ├── Dashboard.tsx         ← NEW: Default landing page
│       ├── DSA.tsx               ← Plan + Revision + Categories
│       ├── SystemDesign.tsx      ← SD plan + categories
│       ├── StackMastery.tsx      ← SM plan + projects
│       └── Analytics.tsx         ← NEW: Velocity + insights
└── public/
    └── (static assets)
```

---

## 4. Pages & Wireframes

### 4.1 Dashboard (Default Landing — The Hero)

The dashboard answers: "What should I work on RIGHT NOW?"

It auto-computes today's context from date math against the plan schedule.

```
┌────────────────────────────────────────────────────────────────────────────┐
│ SIDEBAR (fixed left)          │  MAIN CONTENT                             │
│                               │                                            │
│ ┌───────────────────────┐    │  ┌──────────────────────────────────────┐  │
│ │ [Logo] NeetCode       │    │  │  HERO: "Day 22 · Backtracking"      │  │
│ │        Tracker        │    │  │  Week 4 of 7 · Saturday, Aug 8      │  │
│ └───────────────────────┘    │  │                                      │  │
│                               │  │  ┌─────┐ ┌─────┐ ┌─────┐          │  │
│  [◉] Dashboard               │  │  │ 63  │ │  2  │ │ 21d │          │  │
│  [○] DSA                     │  │  │solved│ │over-│ │strek│          │  │
│  [○] System Design           │  │  │      │ │due  │ │     │          │  │
│  [○] Stack Mastery           │  │  └─────┘ └─────┘ └─────┘          │  │
│  [○] Analytics               │  └──────────────────────────────────────┘  │
│                               │                                            │
│  ─── PROGRESS ───            │  ┌──────────────────────────────────────┐  │
│                               │  │  TODAY'S FOCUS                       │  │
│  DSA    44% ████░░░░         │  │                                      │  │
│  SD      0% ░░░░░░░░         │  │  DSA · Backtracking                  │  │
│  SM      0% ░░░░░░░░         │  │  ☐ Subsets              medium       │  │
│                               │  │  ☐ Combination Sum      medium       │  │
│  ─── STREAK ───              │  │  ☐ Combination Sum II   medium       │  │
│                               │  │                                      │  │
│  🔥 21 days                   │  │  ⚠ REVISION DUE                     │  │
│  Best: 21                    │  │  ☐ Two Sum (2d overdue)  [Redo]      │  │
│                               │  │  ☐ Valid Anagram (1d)    [Redo]      │  │
│                               │  └──────────────────────────────────────┘  │
│                               │                                            │
│                               │  ┌─── THIS WEEK ────────────────────────┐ │
│                               │  │ D22  D23  D24  D25  D26  D27  D28   │ │
│                               │  │ [·]  [ ]  [ ]  [ ]  [ ]  [ ]  [ ]   │ │
│                               │  │ ←today                               │ │
│                               │  └──────────────────────────────────────┘ │
│                               │                                            │
│                               │  ┌─── NEXT WEEK PREVIEW ────────────────┐ │
│                               │  │ Week 5: Graphs · Adv. Graphs · 1-D DP│ │
│                               │  │ 15 Medium · 3 Hard                    │ │
│                               │  │ Key patterns: BFS, DFS, Dijkstra,    │ │
│                               │  │ Topological Sort, Union Find          │ │
│                               │  └──────────────────────────────────────┘ │
│                               │                                            │
│                               │  ┌─── PATTERN HEALTH (compact) ─────────┐ │
│                               │  │ ● Arrays   ● 2Ptr   ● Window  ● Stk │ │
│                               │  │ ● BinSrch  ● LL     ● Trees   ○ Heap│ │
│                               │  │ (green=fresh, yellow=stale, gray=new) │ │
│                               │  └──────────────────────────────────────┘ │
└────────────────────────────────────────────────────────────────────────────┘
```

**Dashboard Logic:**
```typescript
function getTodayContext() {
  const startDate = new Date('2026-07-18');
  const today = new Date();
  const dayNumber = Math.floor((today - startDate) / 86400000) + 1;

  // Find current week and day in plan
  const current = PLAN.flatMap(w => w.days.map(d => ({ ...d, week: w })))
    .find(d => d.day === dayNumber);

  // Get overdue redos
  const overdueRedos = getProblemsForRedo().filter(p => p.overdue_days > 0);

  // Next week
  const currentWeekNum = current?.week.week;
  const nextWeek = PLAN.find(w => w.week === currentWeekNum + 1);

  return { dayNumber, current, overdueRedos, nextWeek };
}
```

### 4.2 DSA Page (Replaces current "Plan" tab)

Keeps the week-accordion structure but adds:
- Auto-open current week
- Highlight today's day with a left border accent
- "Jump to today" floating button if scrolled past

```
┌──────────────────────────────────────────────────────┐
│  NeetCode 150                                        │
│  3 problems/day · 48 days                            │
│                                                      │
│  [Plan]  [Revision]  [Categories]  ← tab bar        │
│                                                      │
│  ████████████████████░░░░░░  63/144 (44%)            │
│                                                      │
│  ┌─ Week 3 — Trees · Tries · Heap ──── 18/21 ─┐    │
│  │  (collapsed — completed week)                │    │
│  └──────────────────────────────────────────────┘    │
│                                                      │
│  ┌─ Week 4 — Backtracking · Graphs ──── 0/21 ──┐   │
│  │  (auto-expanded — current week)               │   │
│  │                                               │   │
│  │  Day 22 · Aug 8  ← highlighted border        │   │
│  │  ☐ Subsets                  [Backtracking] M  │   │
│  │  ☐ Combination Sum         [Backtracking] M  │   │
│  │  ☐ Combination Sum II      [Backtracking] M  │   │
│  │                                               │   │
│  │  Day 23 · Aug 9                               │   │
│  │  ☐ Permutations            [Backtracking] M  │   │
│  │  ...                                          │   │
│  └───────────────────────────────────────────────┘   │
└──────────────────────────────────────────────────────┘
```

### 4.3 Analytics Page (NEW)

```
┌──────────────────────────────────────────────────────┐
│  Analytics                                           │
│                                                      │
│  ┌─── VELOCITY ─────────────────────────────────┐   │
│  │  Problems solved per day (last 21 days)       │   │
│  │  ▁▃▅▇█▅▃▁▃▅▇█▅▃▁▃▅█▅▃  ← sparkline bar     │   │
│  │  Avg: 2.8/day  Target: 3/day  Best: 6        │   │
│  └───────────────────────────────────────────────┘   │
│                                                      │
│  ┌─── COMPLETION FORECAST ──────────────────────┐   │
│  │  Remaining: 81 problems                       │   │
│  │  At 3/day → Sep 4 (27 days)                   │   │
│  │  At 2/day → Sep 18 (41 days)                  │   │
│  │  Current pace → Sep 7 (30 days)               │   │
│  └───────────────────────────────────────────────┘   │
│                                                      │
│  ┌─── CATEGORY MASTERY ─────────────────────────┐   │
│  │  Arrays & Hashing   ██████████████░  9/9 100% │   │
│  │  Two Pointers       ██████████████░  5/5 100% │   │
│  │  Sliding Window     ██████████████░  5/5 100% │   │
│  │  Stack              ██████████████░  6/7  86% │   │
│  │  Binary Search      ██████████████░  7/7 100% │   │
│  │  Linked List        ████████░░░░░░  3/6  50% │   │
│  │  Trees              ██████████████░ 15/15 100%│   │
│  │  Tries              ██████████████░  3/3 100% │   │
│  │  Heap               ░░░░░░░░░░░░░░  0/7   0% │   │
│  │  Backtracking       ░░░░░░░░░░░░░░  0/9   0% │   │
│  │  ...                                          │   │
│  └───────────────────────────────────────────────┘   │
│                                                      │
│  ┌─── REVISION MASTERY ─────────────────────────┐   │
│  │  Mastered (3/3):  12 problems                 │   │
│  │  In Progress:     28 problems                 │   │
│  │  Not Started:     23 problems                 │   │
│  └───────────────────────────────────────────────┘   │
└──────────────────────────────────────────────────────┘
```

---

## 5. Signature Element: Candy Path Spine

Adapted from EasyRoadmaps' `candy-path` timeline. Instead of a full-page zigzag, this is a **compact vertical progress spine** used in:
1. The sidebar (showing week progression)
2. The Dashboard "This Week" section

```css
.candy-spine {
  position: relative;
  width: 1rem;
  border: 2px solid var(--border);
  border-radius: var(--radius-pill);
  background: linear-gradient(
    180deg,
    var(--in-progress) 0%,
    var(--accent) 50%,
    var(--solved) 100%
  );
  box-shadow: 4px 4px 0 0 rgba(251, 191, 36, 0.4);
}

.candy-spine-marker {
  position: absolute;
  left: 50%;
  transform: translateX(-50%);
  width: 2rem;
  height: 2rem;
  border: 3px solid var(--border);
  border-radius: 50%;
  background: var(--surface);
  box-shadow: var(--shadow-pop);
  display: grid;
  place-items: center;
  font-family: "Outfit", system-ui, sans-serif;
  font-weight: 800;
  font-size: 0.7rem;
}

.candy-spine-marker.current {
  background: var(--accent);
  color: white;
  transform: translateX(-50%) scale(1.15);
}

.candy-spine-marker.done {
  background: var(--solved);
  color: white;
}
```

**Usage in sidebar:**
```
  Week 1 ●─── done
  Week 2 ●─── done
  Week 3 ●─── done
  Week 4 ◉─── current (Day 22)
  Week 5 ○─── upcoming
  Week 6 ○
  Week 7 ○
```

---

## 6. Sidebar Navigation

```
┌─────────────────────────────┐
│                             │
│  ┌───────────────────────┐  │
│  │ [LogoMark]            │  │
│  │ NeetCode Tracker      │  │
│  └───────────────────────┘  │
│                             │
│  ┌───────────────────────┐  │
│  │ ◉ Dashboard           │  │  ← pill-shaped, active = accent bg
│  │ ○ DSA                 │  │
│  │ ○ System Design       │  │
│  │ ○ Stack Mastery       │  │
│  │ ○ Analytics           │  │
│  └───────────────────────┘  │
│                             │
│  ─── PROGRESS ───────────   │
│                             │
│  DSA   ████████░░░ 44%     │  ← mini progress bars
│  SD    ░░░░░░░░░░░  0%     │
│  SM    ░░░░░░░░░░░  0%     │
│                             │
│  ─── TODAY ──────────────   │
│                             │
│  Day 22 of 48               │
│  3 problems due             │
│  2 revisions overdue        │
│                             │
│  ┌───────────────────────┐  │
│  │ [Candy Spine]         │  │  ← vertical progress indicator
│  │  W1 ● W2 ● W3 ●     │  │
│  │  W4 ◉ W5 ○ W6 ○     │  │
│  └───────────────────────┘  │
│                             │
│  ─────────────────────────  │
│  [Export] [Import]          │
│                             │
└─────────────────────────────┘
```

**Mobile (< 768px):** Sidebar collapses to a bottom tab bar with icons only:
```
┌────────────────────────────────────┐
│  [🏠] [📝] [🏗] [⚡] [📈]         │
│  Dash  DSA   SD   SM  Stats       │
└────────────────────────────────────┘
```

Note: Icons are Lucide SVGs (LayoutDashboard, Code2, Layers, Zap, BarChart3), NOT emojis. Emojis above are for ASCII representation only.

---

## 7. Interaction Patterns

### Hover & Click (from EasyRoadmaps)

```css
/* All interactive cards */
.card-interactive {
  cursor: pointer;
  transition:
    transform var(--duration-med) var(--ease-pop),
    box-shadow var(--duration-med) var(--ease-pop);
}
.card-interactive:hover {
  transform: translate(-2px, -2px) rotate(-0.25deg);
  box-shadow: var(--shadow-pop-hover);
}
.card-interactive:active {
  transform: translate(2px, 2px);
  box-shadow: var(--shadow-active);
}
```

### Checkbox Completion

When a problem is checked:
1. Checkbox fills with emerald + checkmark SVG appears
2. Problem name gets `text-decoration: line-through` with `color: var(--text-subtle)`
3. Card does a subtle `scale(0.98) → scale(1)` pulse
4. Toast slides up: "Subsets marked done. Next redo in 3 days."
5. Stats update immediately (no page reload)

### Page Transitions

```css
/* Smooth page transitions via React Router */
.page-enter {
  opacity: 0;
  transform: translateY(8px);
}
.page-enter-active {
  opacity: 1;
  transform: translateY(0);
  transition: all var(--duration-slow) ease-out;
}
```

### Keyboard Shortcuts

| Key | Action |
|-----|--------|
| `d` | Toggle done on focused problem |
| `j` / `k` | Navigate problem list |
| `n` | Go to next uncompleted problem |
| `1-5` | Switch page (1=Dashboard, 2=DSA, etc.) |
| `?` | Show shortcut overlay |

---

## 8. Implementation Phases

### Phase 1: Foundation (Day 1-2)
**Goal:** Scaffold React app, migrate data, get sidebar + routing working.

- [ ] Initialize Vite + React + TypeScript + Tailwind v4
- [ ] Set up design tokens in `index.css` (copy from Section 2)
- [ ] Create Shell.tsx with sidebar layout
- [ ] Set up React Router with all 5 routes
- [ ] Create ProgressContext with load/save from Express API
- [ ] Move PLAN, SD_PLAN, SM_PLAN into separate `.ts` data files
- [ ] Verify: sidebar renders, routes switch, data loads from API

### Phase 2: Dashboard (Day 3-4)
**Goal:** The new landing page with today's context.

- [ ] Build `getTodayContext()` utility — date math against plan
- [ ] StatCard component (neobrutalist metric card)
- [ ] Today's Focus section — auto-computed problem list
- [ ] Overdue Revision alerts — surfaced from redo queue logic
- [ ] DayStrip component — visual week progress (7 circles)
- [ ] Next Week Preview card
- [ ] Compact Pattern Health grid (dots only)
- [ ] Verify: Dashboard correctly shows Day 22 content on Aug 8

### Phase 3: DSA Page (Day 5-6)
**Goal:** Migrate plan/revision/categories with improvements.

- [ ] WeekAccordion component — auto-expand current week
- [ ] ProblemRow component — checkbox, name (linked), category pill, difficulty badge
- [ ] Today-highlight: left accent border on current day
- [ ] Revision tab — redo queue + pattern health (full version)
- [ ] Categories tab — progress bars per category
- [ ] "Jump to today" FAB when scrolled away
- [ ] Wire up toggle logic (check/uncheck → state → API → re-render)

### Phase 4: System Design + Stack Mastery (Day 7)
**Goal:** Migrate remaining sections.

- [ ] SD page — same accordion pattern, green accent
- [ ] SM page — same accordion pattern, amber accent, track badges
- [ ] Projects sub-tab for SM

### Phase 5: Analytics (Day 8)
**Goal:** New insights page.

- [ ] Velocity sparkline (pure CSS bar chart, no library needed)
- [ ] Completion forecast calculator
- [ ] Category mastery progress bars
- [ ] Revision mastery stats

### Phase 6: Polish (Day 9-10)
**Goal:** Transitions, responsiveness, accessibility.

- [ ] Page transition animations
- [ ] Mobile responsive: bottom tab bar, stacked layouts
- [ ] Keyboard shortcuts
- [ ] Focus states (visible ring on all interactive elements)
- [ ] `prefers-reduced-motion` media query — disable all transforms
- [ ] Toast notifications with slide-up animation
- [ ] Export/Import functionality
- [ ] Final QA against pre-delivery checklist

---

## 9. Pre-Delivery Checklist (UI UX Pro Max)

| Check | Requirement |
|-------|-------------|
| ☐ | No emojis used as functional icons — all icons are Lucide React SVGs |
| ☐ | `cursor: pointer` on ALL clickable elements (buttons, cards, checkboxes, links, tabs) |
| ☐ | Hover states with smooth transitions (150–300ms) on all interactive elements |
| ☐ | Text contrast ≥ 4.5:1 (WCAG AA) — verified with warm cream background |
| ☐ | Focus states visible for keyboard navigation (`:focus-visible` with accent ring) |
| ☐ | `prefers-reduced-motion` respected — no transforms/animations when enabled |
| ☐ | Responsive breakpoints tested: 375px, 768px, 1024px, 1440px |
| ☐ | No layout shifts on data load (skeleton states or fixed-size containers) |
| ☐ | Tab order logical (sidebar → main content → actions) |
| ☐ | All links have descriptive text (no "click here") |
| ☐ | Cards that link somewhere have full-card click targets |
| ☐ | Loading states don't flash (debounce < 200ms loads) |

---

## 10. Data Model Enhancements

Add these fields to `progress.json` to power new features:

```json
{
  "progress": { /* existing */ },
  "revision": { /* existing */ },
  "revision_v2": { /* existing */ },
  "sd_progress": { /* existing */ },
  "sm_progress": { /* existing */ },

  "settings": {
    "start_date": "2026-07-18",
    "daily_target": 3,
    "theme": "light",
    "current_section": "dashboard"
  },

  "daily_log": {
    "2026-07-18": { "count": 3, "problems": ["Contains Duplicate", "Valid Anagram", "Two Sum"] },
    "2026-07-19": { "count": 6, "problems": ["Group Anagrams", "Top K Frequent Elements", "..."] }
  }
}
```

The `daily_log` is auto-populated when problems are checked — used for velocity calculation and sparkline rendering.

---

## 11. Design Critique (Anthropic Frontend-Design Self-Review)

**Against templated defaults:**
- ✅ Not using the "warm cream + serif + terracotta" AI default — we use cream but with neobrutalist structure (borders, pop shadows) that's grounded in EasyRoadmaps DNA
- ✅ Not using the "dark bg + single neon accent" cliché — this is a warm, approachable tool
- ✅ No numbered 01/02/03 markers on feature sections — problems ARE a sequence (days in plan), so day numbers are justified
- ✅ No donut/pie charts — using progress bars and sparklines which encode actual comparative information
- ✅ Typography is intentional: Outfit is characterful for display (geometric, modern), Plus Jakarta Sans is excellent for sustained reading

**Signature element justified:**
The Candy Path spine directly maps to the subject's world — a guided learning JOURNEY with checkpoints. It's not decoration; it encodes position (where am I?), progress (what's done?), and pacing (am I ahead/behind?).

**Restraint applied:**
- Removed: GitHub heatmap (templated, adds complexity without matching the subject)
- Removed: Radar/spider charts (hard to read, decorative)
- Removed: Dark mode toggle (one mode, done well, for a personal tool)
- Kept bold in ONE place: the Candy Path spine is the visual anchor. Everything else is quiet utility.

**Writing (copy) style:**
- "Day 22 · Backtracking" not "Welcome back! Here's what's next..."
- "2 overdue" not "⚠️ You have 2 problems that need attention!"
- Labels describe what they ARE: "Solved", "Due Review", "Pattern Health"
- Actions say what they DO: "Mark Done", "Redo", "Skip"

---

## 12. Migration Strategy

Since this is a personal tool, we can do a clean cutover:

1. **Keep old `index.html`** renamed to `index-legacy.html` as fallback
2. **Build new app** in `tracker/` directory alongside existing files
3. **Same Express server** — just change the static file serving to point at Vite's build output
4. **Same `progress.json`** — fully backward compatible, new fields are additive
5. **If anything breaks** — `server.js` can be toggled to serve legacy in one line

```javascript
// server.js change (Phase 1):
// Before:
app.get('/', (req, res) => res.sendFile(path.join(__dirname, 'index.html')));
// After:
app.use(express.static(path.join(__dirname, 'dist')));
app.get('*', (req, res) => res.sendFile(path.join(__dirname, 'dist', 'index.html')));
```

---

## Summary

| What | Before | After |
|------|--------|-------|
| Landing experience | Flat week list, manual expansion | Dashboard with today's context in 2 seconds |
| "What's next?" | Mentally compute from dates | Auto-computed, highlighted, surfaced |
| Overdue visibility | Hidden in Revision tab | Red badge on Dashboard + sidebar count |
| Cross-track view | Separate tabs, no summary | Sidebar shows all 3 tracks progress always |
| Visual identity | Generic dark theme | Neobrutalist warmth from EasyRoadmaps |
| Architecture | 113KB single HTML file | Modular React components (~12 files) |
| Mobile | Functional but cramped | Bottom tab bar + responsive grid |
| Accessibility | Basic | Full keyboard nav + focus states + reduced-motion |

**Estimated build time:** 10 focused days (or 5 weekend sessions).
