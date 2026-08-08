import { Outlet } from 'react-router-dom'
import { Sidebar } from './Sidebar'

export function Shell() {
  return (
    <div className="flex min-h-screen">
      <Sidebar />
      <main className="flex-1 min-w-0 p-6 md:p-8 lg:p-10 pb-24 md:pb-10">
        <Outlet />
      </main>
    </div>
  )
}
