public class ExampleClass{
    public int MyProperty { get; set; }

    public void MyMethod() {
        // Accessing MyProperty without null check
        int value = MyProperty * 2; // Potential NullReferenceException
    }
}