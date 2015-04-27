/*•	Describe the strings in C#.
  •	What is typical for the string data type?
  •	Describe the most important methods of the String class.*/

/*A string is an object of type String whose value is text. Internally, the text is stored as a sequential read-only collection of Char objects. There is no null-terminating character at the end of a C# string; therefore a C# string can contain any number of embedded null characters
 * String objects are immutable: they cannot be changed after they have been created. All of the String methods and C# operators that appear to modify a string actually return the results in a new string object. That's why working with strings is a slow operation.
 * 
 * Most important methods:
 *   Length - returns the lenght of the string
 *   this[] - returns the char in the selected position from the string
 *   Compare(str1, str2) - compares the lenght of 2 strings
 *   IndexOf(str) - returns the index of the first occurance of a wanted char in the string
 *   LastIndexOf(str) - returns the index of the last occurance of a wanted char in the string
 *   Substring(startIndex, length) - returns a substring from the string, starting at startIndex with selected lenght
 *   Replace(oldStr, newStr) - returns a new string where all selected chars or substrings are replaced with new strings
 *   Remove(startIndex, length) - returns a new string, where all chars after a starting index with specified lenght are deleted
 *   ToLower() - converts all chars in a string to lowercase
 *   ToUpper() - converts all chars in a string to uppercase
 * */
