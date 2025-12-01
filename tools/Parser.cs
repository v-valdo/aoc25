using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tools;

public static class Parser
{
    public static string[] GetInput(string filepath) => File.ReadAllLines(filepath);
}