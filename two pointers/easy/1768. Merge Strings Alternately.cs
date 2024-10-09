/* 
* @brief Problem Statement
* 
* You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, 
* starting with word1. If a string is longer than the other, append the additional letters onto the end of the merged string.
* Return the merged string. 
*/

public class Solution {
    /**
     * @brief This method merges two strings alternately, taking one character from the first string,
     * and then one character from the second string, continuing until the shorter string is exhausted.
     *
     * @param word1 First string to merge.
     * @param word2 Second string to merge.
     * @return Merged string as a result.
     */

    public string MergeAlternately(string word1, string word2) {
        // StringBuilder used for efficient string building
        StringBuilder merged = new StringBuilder();

        // Variable to store the length of the shorter string
        int smallestLength = word1.Length < word2.Length ? word1.Length : word2.Length;
        
        // Loop through both strings up to the length of the shorter one
        for (int i = 0; i < smallestLength; i++) {
            // Append one character from word1
            merged.Append(word1[i]);
            // Append one character from word2
            merged.Append(word2[i]);
        }

        // If both strings are of the same length, return the merged result
        if (word1.Length == word2.Length) {
            return merged.ToString();
        }
        // If word2 is longer, append the remaining characters from word2
        else if (word1.Length < word2.Length) {
            for (int i = word1.Length; i < word2.Length; i++) {
                merged.Append(word2[i]);
            }
        }
        // If word1 is longer, append the remaining characters from word1
        else {
            for (int i = word2.Length; i < word1.Length; i++) {
                merged.Append(word1[i]);
            }
        }

        // Return the merged result as a string
        return merged.ToString();
    }
}
