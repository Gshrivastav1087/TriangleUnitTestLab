Namespace TriangleUnitTest_Lab2
{
Public Static Class Triangle
{
Public Static String ValidTriangle(int firstAngle, int secondAngle, int
thirdAngle)
{
String result;
If ((firstAngle + secondAngle + thirdAngle) == 180)
{
result = "The triangle is valid.";
}
Else
{
result = "The triangle is NOT valid.";
}
Return result;
}
}
}