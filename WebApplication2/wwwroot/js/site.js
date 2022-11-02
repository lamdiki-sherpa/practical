

// Write your JavaScript code.
function myFunction() {

    var tableList,input, list,filter, div, i, txtValue;
    input = document.getElementById("mySearch");
    filter = input.value.toUpperCase();
    tableList= document.getElementById("myDiv");
    list = tableList.getElementsByTagName("a");
    console.log(list);
    console.log(list.length);
    for (i = 0; i < list.length; i++) {
        div = list[i].getElementsByTagName("div")[0];
        txtValue = div.textContent || div.innerText;
        console.log(txtValue);
        if (txtValue.toUpperCase().indexOf(filter) > -1) {
            list[i].style.display = "";
        } else {
            list[i].style.display = "none";
        }
    }
}


let grid = document.querySelectorAll('.grid-item');
for (let i = 0; i < grid.length; i++) {
    grid[i].addEventListener('click', function () {
        grid[i].style.backgroundColor = "red"
    })
}
/*
function menuFunction() {

    var menuList, input, list, filter, div,divlist, i,txtValue;
    input = document.getElementById("menuSearch");
    filter = input.value.toUpperCase();
    menuList = document.getElementById("menuList");
    list = menuList.getElementsByTagName("a");
    
    console.log(list);
    console.log(list.length);
    for (i = 0; i < list.length; i++) {
        div = list[i].getElementsByTagName("div")[0];
        divlist = div.getElementsByTagName('h5')[0];
        txtValue = divlist.textContent || divlist.innerText;
        console.log(txtValue);
        if (txtValue.toUpperCase().indexOf(filter) > -1) {
            list[i].style.display = "";
        } else {
            list[i].style.display = "none";
        }
    }
}
*/
//-----------------------------increase and decrease-----------------------------------
/*let inc = document.getElementById('inc');
let dec = document.getElementById('dec');
let count = document.getElementById('count');
let counter = 0;
inc.addEventListener('click',function() {
    counter = counter + 1;
    count.textContent = counter;
    
})
dec.addEventListener('click', function () {
    counter = counter - 1;
    count.textContent = counter;

})
*/

/*let notifybtn = document.getElementById('notificationbtn');
let addbtn = document.querySelectorAll('#add');
let initialValue = 0;
for (let i = 0; i < addbtn.length; i++) {
   addbtn[i].addEventListener('click', function () {
     initialValue = initialValue + 1;
       notifybtn.textContent = initialValue;

    })
}
*/
