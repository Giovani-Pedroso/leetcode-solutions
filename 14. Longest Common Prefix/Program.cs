Console.Clear();
Console.WriteLine("Hello, World!");

string LongestCommonPrefix(string[] strs)
{
  int smallest = -1;
  foreach (string x in strs)
  {
    if (smallest == -1 || smallest > x.Length) smallest = x.Length;
    // Console.WriteLine(x);
  }
  string prefix = "";

  for (int j = 0; j < smallest; j++)
  {
    for (int i = 1; i < strs.Length; i++)
    {
      // Console.WriteLine(strs[i][j]);
      if (strs[i][j] != strs[0][j]) return prefix;

    }
    prefix += strs[0][j];
  }


  return prefix;
}

Console.WriteLine(LongestCommonPrefix(["flower", "flow", "flight"]));
Console.WriteLine(LongestCommonPrefix(["dog", "racecar", "car"]));



