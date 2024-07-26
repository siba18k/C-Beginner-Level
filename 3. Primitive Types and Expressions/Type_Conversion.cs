public class _DemoVarandCons
{
    public static void _demoVarandCons()
    {
        byte b = 1; //00000001
        int i = b;// 00000001 00000001 00000001 00000001
        // There is no data loss because the compiler prefixes byte b with '0's in order to make it  four bits
        
        int l = 1;
        float f = l;
        // No data loss will occur here as well    


        // int o = 1;
        // byte e = o;
        // This will not compile because an integer is 4 bytes and a byte is one so data loss will occur
        // Data loss doesnt always happen, it only happpens when the value stored in the int is beyond the capacity of the
        // byte

        // when you want the compiler to go ahead with the conversion (despite dataloss) you do this:
        int e = 1;
        byte o = (byte)e;


        float fl = 1.0f;
        int ing = (int)fl;
        
        // Non-compatible types:
        // string s = "1";
        // int istr = (int)s; //wont compile You need to use the "Convert" class or "Parse" method
        string s = "1";
        int istr = Convert.ToInt32(s);
        int j = int.Parse(s);
        Console.WriteLine(j);

    // Convert methods
    // ToByte()
    // ToInt16()
    // ToInt32()
    // ToInt64()
    // }
}