double MyArraySortAndFindSumm (double[] MyArray)
{
double Result;
Array.Sort(MyArray);  // можно расписать сортировку, но такая запись короче
Result=(double)(MyArray[0]+MyArray[MyArray.Length-1]);
return Result;
}
double[] CraeteArray ()
{
  var rand=new Random();
  double[] ArrayNumbers = new double [rand.Next(1,byte.MaxValue)];
  for (byte i=0;i<(byte)ArrayNumbers.Length;i++)
  {
    ArrayNumbers[i]=(double) (rand.Next(int.MinValue,int.MaxValue)+rand.NextDouble()); // сортировку можно было было впихнуть прямо в цикл создания но особой выгоды,кроме меньшего кода я не вижу, по времени выполнения и еанрузке
  //Console.WriteLine(ArrayNumbers[i]);
  }
  return ArrayNumbers;
}
Console.WriteLine("Результат "+MyArraySortAndFindSumm(CraeteArray()));
