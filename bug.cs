public class MyClass {
    public int MyProperty { get; set; }

    public void MyMethod() {
        // This line might throw a NullReferenceException if MyProperty is null
        int value = MyProperty * 2; 
    }
}