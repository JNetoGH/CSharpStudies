
// 64 bits => 8 bytes
/*
 * byte  => 8  bits => 1 byte
 * short => 16 bits => 2 byte
 * int   => 32 bits => 3 byte
 * long  => 64 bits => 4 byte
 */

Console.WriteLine(float.MaxValue);

// 00000000_00000000_00000000_00000000
// 32 bits
float value = 11203.3123f;
Console.WriteLine(value);

// 00000000_00000000_00000000_00000000_00000000_00000000_00000000_00000000
// 64 bits
double value2 = -13132.123d;
Console.WriteLine(value2);