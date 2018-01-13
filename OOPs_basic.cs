
//****************** ENCAPSULATION*********************************************

public class Vehicle{
    
    private int NoOfWheels { get; set;}  // int 32bit
    private string Model { get;set;}   // string 16bit
    private string Year { get;set;}

    public void Display(){
        // display vehcile information
        System.output("Vehicle model - {0}", this.Model );
    }
}

pubilc void static main(){
    // createing object of class - > total memory space will be allocated as per prperties defined
    Vehicle v = new Vehicle();

    // display information by calling display method
    v.Display();
}

//****************** INHERITANCE*********************************************

public class Employee{
    private string Name ;
    private DateTime DoB;
    private float Basic;
    private float Hra;

    public float CalculateSalary()(
        return Basic + Hra;
    );
}

public class Manager : Employee{ // derived class is being interhited by base means derived class will extend properties or methods
    private int NumberOfStocks;
    private int Parks;

    public float CalculateSalary()(
        return Basic + Hra + Parks;
    );
}

public class SalesPerson  : Employee{ // derived class is being interhited by base means derived class will extend properties or methods
   private int NumberOfSales;
   private int Bonus;

   public float CalculateSalary()(
        return Basic + Hra + Bonus;
    );
}

//****************** METHOD OVERLOADING*********************************************

public class Arithmetic{
        
    public int CalculateSum(int a, int b){
        return a + b;        
    }

    public float CalculateSum(float b){
        return b + 10;   
    }

    public float CalculateSum(float a, float b){
        return a + b;   
    }
}

//****************** METHOD OVERRIDING*********************************************

// You can overide base class method by derived class.

public class Employee{
    public float CalculateSalary(float basic , float hra)(
        return basic + hra;
    );
}

public class Manager : Employee{ // derived class is being interhited by base means derived class will extend properties or methods  
    private float bonus;

    public float CalculateSalary(float basic , float hra)(
        return basic + hra + bonus;
    );
}


pubilc void static main(){
    // createing object of class - > total memory space will be allocated as per prperties defined
    Employee e = new Employee();

    e.CalculateSalary(10000.00, 5000.00);  // this calls base class methods
  
}

