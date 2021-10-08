using System;
using System.Collections.Generic;

namespace CollectionFunction
{
   /*genieric collection
   */
   public class Collection
   {
       List<string> strings = new List<string>();
   

  /* public Collection(string someString)
{
    strings.Add(someString);}

    /* A defult consturctor will look like this "public(used to indicate security type)
    Collection (used for class name) public Collection. unless you create one yourself. 
    this is what the complier will give you}
    */
    

   public void CollectionMain()
   {
    Console.WriteLine ("**** Collection Demo ****");
    Console.WriteLine("List Demo");

    strings.Add("First Element");
    strings.Add("second Element");
    strings.Add("third Element"); 

    Console.WriteLine( "**for each demo**");
    foreach (string thisIsAString in strings)
    {
    Console.WriteLine(thisIsAString);

    }
    Console.WriteLine( "**for loop demo**");
    for (int i = 0; i < strings.Count; i+=2)
    {
    Console.WriteLine("**the current varable is holding two or doing every other**" + i);    
    Console.WriteLine (strings [i]);    
    }
   }
   } 
}