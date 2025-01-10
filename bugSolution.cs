public class ExampleClass{
    public int? MyProperty { get; set; }

    public void MyMethod() {
        // Check for null before accessing MyProperty
        int value = (MyProperty.HasValue) ? MyProperty.Value * 2 : 0; 
    }
}