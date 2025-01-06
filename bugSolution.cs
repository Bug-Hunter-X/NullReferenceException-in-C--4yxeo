public class MyClass {
    public int? MyProperty { get; set; }

    public void MyMethod() {
        // Null check before accessing MyProperty
        int value = MyProperty.HasValue ? MyProperty.Value * 2 : 0; 
    }
}