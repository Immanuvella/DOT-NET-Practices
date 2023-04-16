namespace MultipleInheritance
{
    class myClass3 : myClass1, myInterfaceClass
    {
        myClass1 S1 = new myClass1();
        myClass2 S2 = new myClass2();

        // Overriding print1() method of myAbstractClass
        public override void print1()
        {
            S1.print1();
        }

        public void print2()
        {
            S2.print2();
        }
    }
}