int[] CraeteArray ()
{
  var rand=new Random();
  int[] ArrayNumbers = new int [rand.Next(1,byte.MaxValue)];
  for (byte i=0;i<(byte)ArrayNumbers.Length;i++)
  {
    ArrayNumbers[i]=rand.Next(int.MinValue,int.MaxValue);
    //  Console.WriteLine(ArrayNumbers[i]);
  }
  return ArrayNumbers;
}
long Results (int[] ArrayNumbers, bool Even)
{
  long Result=0;
  for (byte i=0; i<(byte)ArrayNumbers.Length;++i)     // элемент с индексом 0 в любом случае не учитывается. если нужно вместе с ним то поменять на i++
  if (Even)
  {
    if(i%2==0)
    {
      Result=checked(Result+ArrayNumbers[i]);
    }
    }else if(i%2!=0)
    {
      Result=checked(Result+ArrayNumbers[i]);
    }
    return Result;
  }
  bool Even = false; // не понял задание, текст и пример не сходятся, ввел оба варианта
  Console.WriteLine("Результат "+Results(CraeteArray(),Even));
