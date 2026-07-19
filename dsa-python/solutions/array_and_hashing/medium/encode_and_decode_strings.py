# 271. Encode and Decode Strings
# https://leetcode.com/problems/encode-and-decode-strings/
#
# Design an algorithm to encode a list of strings to a string. The encoded
# string is then sent over the network and is decoded back to the original
# list of strings.
#
# APPROACH: Length-prefix encoding (length + delimiter + data)
#
# KEY INSIGHT: Prepend each string with its length and a '#' delimiter.
# The decoder reads the length first, then grabs exactly that many chars.
# This handles ANY content (including '#', digits, empty strings).
#
# FORMAT: "{len}#{data}{len}#{data}..."
# EXAMPLE: ["hello","world"] → "5#hello5#world"
#
# WHY IT WORKS: We never search for a delimiter inside the data.
# We read a number, skip the '#', then take exactly N characters.
#
# TIME: O(n) — n = total characters across all strings
# SPACE: O(n) — the encoded/decoded output


class EncodeAndDecodeStrings:
    def encode(self, strs: list[str]) -> str:
        result = ""
        for s in strs:
            result += str(len(s)) + "#" + s  # Prepend length + delimiter
        return result

    def decode(self, s: str) -> list[str]:
        result = []
        i = 0

        while i < len(s):
            j = i
            while s[j] != "#":      # Find the '#' delimiter
                j += 1
            length = int(s[i:j])     # Extract the length (digits before '#')
            result.append(s[j+1 : j+1+length])  # Grab exactly 'length' chars after '#'
            i = j + 1 + length       # Move pointer past this string

        return result
