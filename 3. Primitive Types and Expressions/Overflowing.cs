// Overflowing

// Each type, depending on the number of types allocated to it, can store a range of values. If we 
// store a value in a variable, but that value exceeds the boundary of values for the underlying type, 
//     overflow happens. For example, we can store any values between 0 and 255 in a byte. If the 
//     value of a byte exceeds this boundary during computations, overflow happens. Here is an 
//     example:
    // byte b = 255;
    // b = b + 1;
    // As a result of the second line, the value of b will be 0. - This is what we call overflowing: We havr exceeded the
    // boundary of the byte data type in C#
// In order to stop Overflowing you need to use the "checked" keyword

checked
{
    byte number = 2;
    
    number = (byte)(number + 1);
    Console.WriteLine(number);
}
