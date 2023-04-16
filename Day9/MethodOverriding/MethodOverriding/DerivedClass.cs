namespace MethodOverriding
{
    public class DerivedClass : clssA
    {


        // 'clssA()' [no argument constructor]

        public DerivedClass() : base() { }


        // This constructor will instantiate
        // 'clssA(int i, int j)' [parameterized

        public DerivedClass(int i, int j) : base(i, j) { }
    }
}