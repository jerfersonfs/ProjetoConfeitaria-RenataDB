/*function fruitProcessor(apples,oranges){
    console.log(apples, oranges);
    const juice = 'Juice with '+apples+' apples and '+oranges+' oranges.';
    return juice;
}

const appleJuice = fruitProcessor(5,0);
console.log(appleJuice);*/

/*const calcAge2 = function (birthYear){
    return 2025 - birthYear;
}
const calcAge3 = birthYear => 2025 - birthYear;
const age3 = calcAge3(2006);
console.log(age3)

const yearUntilRetirement = birthYear => {
    const age = 2037 - birthYear;
    const retirement = 65 - age;
    return 'Your retires in '+ retirement+' years';
}

console.log(yearUntilRetirement(2006))*/

/*function cutPieces(fruit){
    return fruit * 4;
}*/
/*const calcAvarage = (a , b , c) => a + b + c / 3;{
    console.log(calcAvarage(3,4,5))
}

const scoreDolphins = (44 + 23 + 71) / 3;
const scoreKoalas = (65 +54+ 49) /3;
console.log (scoreDolphins,scoreKoalas);

function checkWinner(avgDolphins , avgKoalas){
    if (avgDolphins >= 2 * avgKoalas){
        console.log('Dolphins win ('+avgDolphins+' vs '+avgKoalas+')')
    }
    else if (avgKoalas >= 2 *avgDolphins){
        console.log('Koalas win ('+avgKoalas+' vs '+avgDolphins+')')
    }
    else{
        console.log('No team wins...')
    }
}
checkWinner(500,100/*scoreDolphins,scoreKoalas*/;
/*const calAge = function(birthYear){
    return 2025 - birthYear
}
const years = [1990,1967,2002,2010,2018];

const age1 = (calAge(years[0]));
const age2 = (calAge(years[1]));
const age3 = (calAge(years[2]));

const ages = (age1,age2,age3);
console.log(ages());*/

/*const calcTip = function(bill){
    return bill >= 50 && bill <= 300 ? bill * 0.15 : bill * 0.2;
}

const bills = [125,555,44];
const tips = [calcTip(bills[0]),calcTip(bills[1]),calcTip(bills[2])];
const total = (bills[0] + tips[0])+bills[1] + tips[1]+bills[2] + tips[2];
console.log(bills,tips);*/
/*const je ={
name: 'Jé',
sobrenome: 'Freitas',
aniversario: 2006,
trabalho: 'almoxerifado',
amigos:['Jão','Pedro','Mandatto'],
cnh: true,

calcAge : function() {
console.log(this);
return 2025 - this.aniversario;
},
sumario: function (){
    return je.name +'tem'+this.aniversario+' anos e'+ this.cnh ?'tem' :'não tem' + 'carteira de motorista'  
}
};
console.log(je.sumario())
console.log(je.calcAge());*/
/*const mark = {
fullname: 'Mark Miller',
mass: 78,
height: 1.69,

calcBMI : function(){
    this.bmi = this.mass / this.height **2
    return this.bmi;
}
};
const john = {
fullname: 'John Smith',
mass: 92,
height: 1.95,

calcBMI : function(){
    this.bmi = this.mass / this.height **2
    return this.bmi;
}
};
mark.calcBMI();
john.calcBMI();
console.log(mark.bmi,john.bmi);

if (john.bmi > mark.bmi){
console.log(john.fullname + ' BMI '+john.bmi+ ' maior que ' + mark.fullname +' BMI ' + mark.bmi)
}
else if (mark.bmi > john.bmi){
console.log(mark.fullname + ' BMI '+mark.bmi+ ' maior que ' + john.fullname +' BMI ' + john.bmi)
};*/
/*let dice = Math.trunc(Math.random() *6) + 1;
while (dice !== 6){
    console.log('You rolled a '+dice);
    dice = Math.trunc(Math.random() *6) + 1;
    if (dice === 6) console.log('End')    
}*/

const calcTip = function(bill){
  return bill >= 50 && bill <= 300 ? bill * 0.15 : bill * 0.2
}

const bills = [22,295,176,440,37,105,10,1100,86,52];
const tips = [];
const totals = [];

for(let i = 0; i < bills.length; i++){
    const tip = calcTip(bills[i]);
    tips.push(tip);
    totals.push(tip + bills[i]);
}
console.log(bills,tips,totals);

const calcAvarage = function(arr){
    let sum = 0;
    for(let i = 0;i < arr.length; i++){
        sum += arr[i];
    }
    return sum / arr.length;
}
console.log(calcAvarage([1,2,3,4,5]));
console.log(calcAvarage(totals));
console.log(calcAvarage(tips));