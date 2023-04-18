using System;
namespace GenericsDemo
{
   
    class MyGenericClass<T>
    {
        //Generic variable
        //The data type is generic i.e. T
        private T GenericMemberVariable;

        public MyGenericClass(T value)
        {
            GenericMemberVariable = value;
        }

        //Generic Method
        
        public T GenericMethod(T GenericParameter)
        {
            Console.WriteLine($"Parameter type: {typeof(T).ToString()}, Value: {GenericParameter}");
            Console.WriteLine($"Return type: {typeof(T).ToString()}, Value: {GenericMemberVariable}");
            return GenericMemberVariable;
        }

        //Generic Property
      
        public T GenericProperty { get; set; }
    }
}