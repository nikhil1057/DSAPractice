# 621. Task Scheduler
# https://leetcode.com/problems/task-scheduler/
#
# You are given an array of CPU tasks, each represented by a character, and a
# cooling interval n. Each cycle allows completion of one task. Tasks can be
# completed in any order, but identical tasks must be separated by at least n
# intervals due to cooling time. Return the minimum number of intervals the CPU
# will take to finish all the given tasks.
#
# Example 1: Input: tasks = ["A","A","A","B","B","B"], n = 2 Output: 8
#   (A -> B -> idle -> A -> B -> idle -> A -> B)
# Example 2: Input: tasks = ["A","C","A","B","D","B"], n = 1 Output: 6
# Example 3: Input: tasks = ["A","A","A","B","B","B"], n = 3 Output: 10
#
# Constraints:
# - 1 <= tasks.length <= 10^4
# - tasks[i] is an uppercase English letter.
# - 0 <= n <= 100


class TaskScheduler:
    def least_interval(self, tasks: list[str], n: int) -> int:
        pass
