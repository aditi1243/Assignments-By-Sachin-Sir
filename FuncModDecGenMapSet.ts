//Functions in TypeScript

function add(a, b) {
    return a + b;
}
var sum = add(1, 2);
 var sum = add("Hi", "Hello!!!!!!");
var sum = add(126789.3456, 10.234);
var sum = add("Hi", 3);
console.log(sum);

//Another function
function subtract(a:number, b:number) {
    return a - b;
}
var result = subtract(4, 2)
console.log(subtract);


// Anonymous function
let Add = function (x, y) {
    return x + y;
};

//Access modifiers ====>private
class Person {
    constructor(private fname, private lname, private gender) { //Whenever we use private AM
                                                               //we intend to create the contr to initialize the value from the same AM
    }
    getBasicInfo() {
        console.log('Name:' + this.fname + '' + this.lname);
        console.log('Gender:' + this.gender);
    }
}
let a = new Person('Aditi', 'Raghuvanshi', 'Female');
a.getBasicInfo();

//Another Example ==>private
class Employee {
    public empID: number;
    private empName: string;

    constructor(ID: number, Name: string) {
        this.empID = ID;
        this.empName = Name;
    }
    public  display() {
       // return (`Employee ID :`{ this.empID; + " " + "EmployeeName": { this.Name }`);
        return (`Employee ID :{this.Name}="Aditi"`);

}//Closing block of Class: Employee

 //Instantiation

let Emp = new Employee(101, "adi");
Emp.empID = 101;
console.log(Emp.display());
//Emp.empName = "Aditi";  ==>Accessible only inside the class


//Access modifiers ====>public ===> public, so they can be accessible outside of the class using an object of the class
class Student {
    public stdName: string;
    stdCourse: string;
}

let std = new Student();//Instance Created for accessing
std.stdName = "Aditi";
std.stdCourse = "Bachelor of technology";
console.log(std.stdName + " " + std.stdCourse);

//Protected ==> accessible in child classes

class Manager {
    public empName: string;
    protected empID: number;

    constructor(name: string, Id: number) {
        this.empName = name;
        this.empID = Id;
    }
}

class Subordinates extends Manager {
    private department: string;

    constructor(name: string, Id: number, department: string) {
        super(name, Id); //By using Super Keyword this class will act as Parent Class 
        this.department = department;
    }
}
let manager = new Subordinates("Aditi Singh", 101, "HR");
console.log()

//ReadOnly ==>only for reading purpose ==>Read-only members can be accessed outside the class, but their value cannot be changed.
class plant{
    readonly name: string;
    readonly numOfroots: number = 8;//We cannot assign any values to it they are only for reading purpose

    constructor(Name: string) {
        this.name = Name;
    }
}

let stem = new plant("Hi!!! I'am Ashok");

//Module ===>To avoid conflicts of globally accessing variables we use this concept

//Variable
var x: string = "Hi!!! I'am crazy";//Globally Declared
export var y: string = "Welcome to My World"; //By using this we restrict the use of global variable
                                              //For using we have to import it

//Syntax of Import ==> import{variable name }from <location of the file for importing by using Dot operator and FORWARD SLASH and inside double quotes> 
                       //import{y} from "./test1/"
//Function
export function myfunct(): void {
    console.log("This is my function")
}

//Class
export class myclass
{
    a: number;
    b: number;
    constructor(a: number, b: number) {
        this.a = a;
        this.b = b;
    }

    add = () => {
        return (this.a + this.b)
    }
}

//Typescript Decorator  =>








//Generics
function echo<T>(arg: T): T { //To tell to typescript that argument and returning value 
                                  //of  a function should be as same, T is a placeholder                                                            
    return arg; 
}
//var myStr : string = echo(1) // ==> It will bring an error becoz DT are not same
var myStr = echo(1);

class SalesMgr {
    fname: string;
    lname: string;
    constructor(fname: string, lname: string) { //constructor
        this.fname = fname;
        this.lname = lname;
    }
   public getFullName() { //Declaration of Methods
        return this.fname + " " + this.lname;

    }
}
class Admin extends SalesMgr { }
class HRMgr extends SalesMgr { }

let admin = new Admin('a', 'a');

function Echo<T extends SalesMgr>(SalesMgr: T): T{ //
    return SalesMgr;
}

var foo = Echo(admin);


//Typescript Map and Set


let map = new Map(); //map have values and keys 
map.set(123, 'abc')
map.set(345, 'ghi');
map.set(true, false);
console.log(map);   //Can contain duplicate values  but keys should be unique

let names = ['Aditi', 'Arti', 'Akansha', 'Preeti', 'nidhi']
names.push('Aditi');

let set = new Set(names);//Set have only values
console.log(names);
console.log(set); //Cannot contain duplicate values 



















