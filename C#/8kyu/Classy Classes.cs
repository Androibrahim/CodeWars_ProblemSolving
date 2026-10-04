public class Person
{  
  string Name =""; 
  int Age =0;
  public Person(string name , int age)
  {
      Name = name;
      Age = age; 
  }
    
  public string  Info { get => $"{Name}s age is {Age}";  } 
}