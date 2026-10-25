// console.log("test");

// var flag = true;
// var fname = "men3m";
// var age = 22;
// age = "men3m";
// console.log(age);

// is not implicit type local variable (C#)


/**
      Typed                       Not Typed
Loosely Typed   Strongly Typed
     JS              C#
    
  Car c = new Bike();  Car c = new Car();  
*/


/**
   Primitive DT                Reference DT
      Number                   anything else
      String
      Boolean
      Undefined
      Null
      (Symbol) >> ES6
*/

// myFirstName
// MyFirstName
// var _name  = "hasan";

/**
    - Literal Creation: var sub = "JS";
    - Method Creation:

*/

// var subject = String("js");
// var salary = Number(19930);
// console.log(salary);


// var fname;
// console.log(fname);


// reassign
// var x = 112;
// x = -2;
// console.log(typeof(x));
// x = "men3m";
// console.log(typeof(x));
// x = false;
// console.log(typeof(x));

// redeclaration
// var org = "DEPI";
// console.log(org) 

// var org = 1234;
// console.log(org);

// var z = Number(50);
// console.log(z);
// console.log(typeof z);


// var x = Number("50");
// console.log(x);
// console.log(typeof x);

// var y = Number("Depi");
// console.log(y);
// console.log(typeof y);


// var flag = Boolean(true);
// console.log(flag);
// var flag = Boolean(false);
// console.log(flag);

// var flag = Boolean("men3m");
// console.log(flag);
// var flag = Boolean(34);
// console.log(flag);
// var flag = Boolean([1,23]);
// console.log(flag);

// falsy values
    // false
    // zero
    // null
    // ""
    // undefined
    // nan
// truthy values
    // anything else

// "50"  error  50 number
//error ish nan




// +, -

// var n1 = 23;
// var n2 = 12;
// console.log(n1+n2); // summation

// var n1 = "23";
// var n2 = "12";
// console.log(n1+n2); // concatination

// var n1 = 23;
// var n2 = "12";
// console.log(n1+n2); // concatination

// var n1 = 23;     // String("23");
// var n2 = "depi"; // Nubmer("depi");
// console.log(n1+n2); // concatination

// var str1 = "ola";
// var str2 = "ahmed";
// console.log(str1+str2); // concatination

// Coercion: is the process of converting a datatype into another one


// undefined + undefined = nan
// undefined + 20 = nan
// 20 + undefined = nan
// 20 + nan = nan
// nan + nan = nan
// 20 + null = 20
// null + null = 0

// console.log(undefined + undefined)
// console.log(undefined + 20)
// console.log(20 + NaN)
// console.log(NaN + NaN)
// console.log(20 + null)
// console.log(null + null)

// 20 - null = 20
// console.log(20 - 2);
// console.log(20 - "2");
// console.log(20 - "depi"); // Number("?")


// > >= < <= == === != !==

var a = 11;
var b = 23;
// console.log(a > b);

// b = "-23";
// console.log(a > b);

// a=11;
// b=11;
// console.log(a==b);

// a=11;
// b="11";
// console.log(a==b);

// a = "depi";
// b = "depi";
// console.log(a === b); // false


// var n1 = true;   // Number(true)=1
// var n2 = "true"; // Number("true")=nan
// console.log(n1==n2);
// console.log(n1 === n2);

// console.log(isNaN(4));   // false
// console.log(isNaN("4")); // false
// console.log(isNaN("depi")); // true


/** Bitwise And
    true true > true
    anything else > false
*/
// console.log((-11 > -2) && (11>2)); 
// console.log((-11 < -2) && (11<2)); 
// console.log((-11 < -2) && (11>2)); 
// console.log((-11 > -2) && (11<2)); 

/** Bitwise OR
    false false > false
    anything else > true
*/

// console.log((-11 > -2) || (11>2)); 
// console.log((-11 < -2) || (11<2)); 
// console.log((-11 < -2) || (11>2)); 
// console.log((-11 > -2) || (11<2)); 


/** NOT
    true > false
    false > true
*/


// Short Circuit
// console.log("mona"||"ola");    // mona
// console.log(undefined||"ola"); // ola
// console.log("ola"||undefined); // ola
// console.log(""||undefined); // undefined

// console.log("mona"&&"ola");    // ola
// console.log(undefined&&"ola"); // undefined
// console.log("ola"&&NaN); // NaN
// console.log(""&&undefined); // ""


// function greet(){
//     console.log("hellooo");    
//     // return undefiend
// }

// var res = greet();
// console.log("res = ", res);


// function sum(a, b){
//     return a+b;
// }

// var out = sum(2,3);

// console.log(greet || "ola");
// console.log(greet() || "ola");
// console.log(greet() && "ola");

// var cvv = prompt("enter your cvv: ");
// var balance = 20.30;
// var amountToBeDeducted = 10.20;
// console.log("before: ", balance);
// if(cvv == "123" && balance >= amountToBeDeducted){
//     balance-=amountToBeDeducted;
//     alert("payment succedded");
//     document.writeln("after: ", balance);
// } else {
//     alert("payment failed due to incorrect cvv or insufficient balance");
// }
// console.log("after: ", balance);

// var flag = false;
// var flag = true;
// console.log(flag?"positive":"negative");

// for(initialization;stopping condition;step){body}

// for(var idx = 0; idx<10; idx++){
//     console.log("hello, world");    
// }

// var idx = 0; 
// for(;idx<10;){
//     console.log("hello, world");    
//     idx++;
// }

// var idx = 0; 
// while(idx<10){
//     console.log("hello, world");    
//     idx++;
// }

// var idx = 0; 
// do{
//     console.log("hello, world");
//     idx++;
// }while(idx<10);

