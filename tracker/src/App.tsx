import { BrowserRouter, Routes, Route, Navigate } from 'react-router-dom'
import { ProgressProvider } from './state/ProgressContext'
import { Shell } from './components/Shell'
import { Dashboard } from './pages/Dashboard'
import { DSAPage } from './pages/DSAPage'
import { SystemDesignPage } from './pages/SystemDesignPage'
import { StackMasteryPage } from './pages/StackMasteryPage'
import { AnalyticsPage } from './pages/AnalyticsPage'

export function App() {
  return (
    <ProgressProvider>
      <BrowserRouter>
        <Routes>
          <Route element={<Shell />}>
            <Route path="/" element={<Dashboard />} />
            <Route path="/dsa" element={<DSAPage />} />
            <Route path="/system-design" element={<SystemDesignPage />} />
            <Route path="/stack-mastery" element={<StackMasteryPage />} />
            <Route path="/analytics" element={<AnalyticsPage />} />
          </Route>
          <Route path="*" element={<Navigate to="/" replace />} />
        </Routes>
      </BrowserRouter>
    </ProgressProvider>
  )
}
