int[] CraeteArray ()
{
  var rand=new Random();
  int[] ArrayNumbers = new int [rand.Next(1,byte.MaxValue)];
  for (byte i=0;i<(byte)ArrayNumbers.Length;i++)
  {
    ArrayNumbers[i]=rand.Next(100,1000);
    //  Console.WriteLine(ArrayNumbers[i]);
  }
  return ArrayNumbers;
}
byte ResultMessage(int[] ArrayNumbers)
{
  byte Count=0;
  for (byte i=0; i<(byte)ArrayNumbers.Length;i++)
  {
    if(ArrayNumbers[i]%2==0)
    {
      Count++;
    }
  }
  return Count;
}
Console.WriteLine("Результат "+ResultMessage(CraeteArray()));
