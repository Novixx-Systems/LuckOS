using System.Diagnostics;

string resourcecurrent = File.ReadAllText("M:\\NVXLKOS\\DEVTOOL\\STORAGE\\VERSION.RC");     // Change this path to where LuckOS "source code" is stored
string toBeSearched = " build ";
int ix = resourcecurrent.IndexOf(toBeSearched);

if (ix == -1)
{
    Console.WriteLine("Could not find string");
}
string bnum = resourcecurrent.Substring(ix + toBeSearched.Length)[..5];
Console.WriteLine("New Build Number (current is " + bnum + "): ");
string newBnum = Console.ReadLine().PadLeft(5, '0');
File.WriteAllText("M:\\NVXLKOS\\DEVTOOL\\STORAGE\\VERSION.RC", resourcecurrent.Replace(" build " + bnum, " build " + newBnum));
Process.Start("M:\\NVXLKOS\\DEVTOOL\\RH\\RESE.exe", "-open M:\\NVXLKOS\\DEVTOOL\\STORAGE\\VERSION.RC -save M:\\NVXLKOS\\DEVTOOL\\STORAGE\\VERSION.RES -action compile -log NUL").WaitForExit();
Process.Start("M:\\NVXLKOS\\DEVTOOL\\RH\\RESE.exe", "-script M:\\NVXLKOS\\DEVTOOL\\STORAGE\\VERUPD.TXT").WaitForExit();
File.Copy("M:\\NVXLKOS\\DEVTOOL\\STORAGE\\SHELL32TMP.DLL", "M:\\NVXLKOS\\DEVTOOL\\STORAGE\\SHELL32.DLL", true);
Process.Start("makecab", "M:\\NVXLKOS\\DEVTOOL\\STORAGE\\SHELL32.DLL M:\\NVXLKOS\\DATA\\I386\\SHELL32.DL_").WaitForExit();
Console.WriteLine("Done");