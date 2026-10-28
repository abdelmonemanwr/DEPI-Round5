// console.log("test");

// function funName(){

// }

// function sum(){
//     var x = 3;
//     var y = 2;
//     console.log(x+y);
// }
// sum();

// function sum(x, y){
//     // var x = 2;
//     // var y = 23;
//     // console.log(x);
//     // console.log(y);
//     // console.log(arguments);
    
//     console.log(x+y);
// }

// sum(20, 30);

// sum(5,4);
// sum(5);
// sum();
// sum(3,35,64, 45);

// sum(true, true);

// var result = sum(2,4);
// console.log(result);


// function sum(x=0, y=0){
//     return x+y;
// }

// function sum(x, y){
//     x = x || 0;
//     y = y || 0;
//     return x+y;
// }

// var result = sum();
// console.log(result);

// var result = sum(2,4);
// console.log(result);


// mult();


// var c = 3+6;
// var result = function doSomething(x,y){
//     return x+y;
// }

// var result = function (x,y){
//     return x+y;
// }

// doSomething(23,34);
// console.log(result(23,34));

// var result = function (x, y){
//     console.log(x+y);
// }

// vr x = result(3,5);
// console.log(x);

// console.log(result(3,5));


// var result = function (x, y){
//     console.log("entered function");    
//     return (x+y);
// }

// result(3,5);

// console.log(student);

// let student = "men3m";
// console.log(age);
// var age = 22;
// console.log(age);

// console.log(window);
// console.log(this);


// console.log(sub(2, 9));
// function sub(x,y){
//     return x-y;
// }



// let price = 23;
// console.log(price);

// console.log(bdate);
// var bdate = "23/10/2000";
// console.log(bdate);

// console.log(sum(2,5));
// function sum(x,y){
//     return x+y;
// }
// console.log(sum(2,5));

// // console.log(result(2,5));
// var result = function (n,m){
//     return n*m;
// }
// console.log(result(2,5));




// function greet(x){
//     console.log("hello", x);
// }

// greet("men3m");
// greet(23);

// gre

// function test(fun, num){
//     console.log(fun);
//     console.log(num);
// }

// var result = function (x,y){
//     return x+y;
// }

// test(result, 5);

// setTimeout(() => {
//     console.log("blbllb");
// }, 3000);


// let idx = 0;
// var currentIntervl = setInterval(()=>{
//    console.log(idx++);
//    if(idx==5){
//     console.log("entered");
    
//        clearInterval(currentIntervl);
//    }
// }, 2000)

// var fnme2= "men3m";
// var fnme3 = "gbril";
// var ge2=22;
// var ge3=45;

// var person = {}; // empty object
// k:v,
// var person = {
//     fname: "ali",
//     lname: "mohamed",
//     age: 20,
//     address:"benha",
// };
// dot notation
// console.log(person);
// console.log(person.fname);

// sub notation
// console.log(person["lname"]);

// console.log(person.gender);

// person.address="cairo";
// person.gender = true;

// console.log(person);

// var person = {
//     fname: "ali",
//     lname: "mohamed",
//     age: 20,
//     address:{
//         city: "alex",
//         street: "sid gaber 23.432",
//         code: "233426"
//     },

//     display: function(){
//         console.log("hello");;
        
//     }
// };


// console.log(person.address.code);
// console.log(person["address"]["code"]);
// console.log(person["address"].city);
// console.log(person.address["code"]);

// var mykey = "age";
// console.log(person[mykey]);   // undefined  20
// console.log(person.mykey);    // undefined  undefined 
// console.log(person["mykey"]); // undefined  undefined 


// person.display();


// console.log(document);

// var element = document.getElementById("btn");
// console.log(element);

// var elements = document.getElementsByClassName("parent");
// console.log(elements[0]);

// var elements = document.getElementsByClassName("content");
// console.log(elements);

// for(var i=0; i<elements.length; i++){
//     console.log(elements[i]);
// }

// var elements = document.getElementsByName("user");
// for(var i=0; i<elements.length; i++){
//     console.log(elements[i]);
// }

// var elements = document.getElementsByTagName("p");
// console.log(elements);

// var element = document.querySelector("#btn");
// console.log(ele);

// var element = document.querySelector(".content");
// console.log(element);

// var elements = document.querySelectorAll(".content");
// console.log(elements);
// elements.forEach(()=>{
//     log
// })



var parent = document.getElementById("parent");
// console.log(parent);
// console.log(parent.firstChild);
// console.log(parent.firstElementChild);
// console.log(parent.lastChild);
// console.log(parent.lastElementChild);
// console.log(parent.children);
// console.log(parent.childNodes);



// console.log(document.body);
// console.log(document.images);
// console.log(document.forms);
// console.log(document.links[0]);

var p = document.querySelector(".content");
// var element = document.createElement("p");
function changeContent(){
    // console.log(p);
    // p.innerHTML="<h2>men3m is greeting you</h2>";
    // p.innerText="<h2>men3m is greeting you</h2>";
    // p.textContent="men3m is greeting you";
    // p.style.color="black";
    // p.style.backgroundColor="green";

    // p.classList.remove("content");
    // p.classList.add("big");
    // p.classList.toggle("big");
    // p.classList.contains("big");

    // console.log(p);
    // p.className="small";
    // console.log(p);



    console.log("clicked");


}

var userInput = document.getElementById("user");
function getText(){
    // console.log("clicked");
    
    // console.log(userInput);
    console.log(userInput.value);

    
    
}