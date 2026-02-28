namespace OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part01
            #region Q1
            /*
             Binding : happened when reference from parent refere to object from chlid 
            EX: Person student = new Student(); (binding)
               Person student = new Person();   (no binding) refrence and object same type

            static Binding                      Vs                 Dynamic Binding
              based on reference  type                              based on object type
                                                                
      class A                                                       class A
{                                                                       {
   public void Show()
        => Console.WriteLine("A");                                                     
                                                                         public virtual void Show()
            }
class B : A                                                              => Console.WriteLine("A");
                                                                     }
   {
    public void Show()                                                           class B : A
                                                                     {
             => Console.WriteLine("B");
}                                                                                  public override void Show()
                                                             
A obj = new B();
obj.Show();                                                           
                                                                                      => Console.WriteLine("B");
     out put A                                                                                         }
                                                                     A obj = new B();  
                                                                     output B
                                                    
                                                    
                                                     
             */
            #endregion
            #region Q2
            /*
             method overloading : static Polymorphism (same method with different behavior and sinature) in the same class (no inheritance)

            method overriding : Dynamic  Polymorphism (same method with different behavior) in child class (with inheritance)
             
             
             */
            #endregion
            #region Q3
            /*
            virtual Keyword : allow child class override the method or property (change it) and CLR discuss 
            which method used in the run-time 
             
             
             */
            #endregion
            #endregion
        }
    }
}
