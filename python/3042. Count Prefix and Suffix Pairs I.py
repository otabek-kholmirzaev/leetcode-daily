# https://leetcode.com/problems/count-prefix-and-suffix-pairs-i/

class Solution(object):
    def countPrefixSuffixPairs(self, words):
        count = 0
        n = len(words)
        for i in range(n):
            l = len(words[i])
            for j in range(i+1, n):
                len_i, len_j = len(words[i]), len(words[j])
                if words[j][0:len_i] == words[i] and words[j][len_j-len_i:] == words[i]:
                    count += 1

        return count
        