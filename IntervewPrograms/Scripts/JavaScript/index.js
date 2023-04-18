// JavaScript source code

console.log("hello from js");
const root = document.getElementById("root");
const createRow = () => {
  const row = document.createElement("div");
  row.className = "row";
  return row;
};

const createColumn = (innetText) => {
  const col = document.createElement("div");
  col.className = "col col-3";
  col.innerText = innetText;
  return col;
};

const createButton = (text) => {
  const btn = document.createElement("button");
  btn.innerText = text;
  btn.className = "btn btn-success col-1";
  return btn;
};

const createHeading = (text, tag) => {
  let header;
  switch (tag) {
    case "h1":
      header = document.createElement("h1");
      break;
    case "h2":
      header = document.createElement("h2");
      break;
    case "h3":
    default:
      header = document.createElement("h3");
      break;
  }
  header.innerText = text;
  return header;
};

const createInput = (id, initialvalue = "", type = "text") => {
  const inp = document.createElement("input");
  inp.type = type;
  inp.value = initialvalue;
  inp.id = id;
  inp.className = "col-1 ms-2 me-2";
  return inp;
};

const dataTypes = "Data types present in javascript";
const primitiveDatatypes = [
  "string",
  "number",
  "BigInt",
  "Boolean",
  "undefined",
  "null",
  "Symbol - newly introduced in ES6",
];

addDataTypes = () => {
  const dataTypesText = createRow();
  dataTypesText.innerText = "Below are the premitive datatypes";
  root.appendChild(dataTypesText);
  const newRow = createRow();
  primitiveDatatypes.forEach((element) => {
    newRow.appendChild(createColumn(element));
  });
  root.appendChild(newRow);
};
addDataTypes();

const closureFunction = () => {
  let counter = 0;
  const fn = () => {
    return (counter += 1);
  };
  return fn();
};

var immediateFunction = (function () {
  let counter = 0;
  var increment = function () {
    return (counter += 1);
  };
  return increment;
})();

const closureExample = () => {
  const closureBody = createRow();
  const sectionHeader = createHeading("Closures example");
  const btn = createButton("Increment");
  btn.onclick = () => btnClick();
  const inp = createInput("closure", 0);
  closureBody.append(sectionHeader, inp, btn);
  root.appendChild(closureBody);
};
closureExample();

var btnClick = function () {
  const clo = document.getElementById("closure");
  clo.value = immediateFunction();
};

//console.log(immediateFunction());

//JavascriptClosure
//statefull self invoking function
var count = (function () {
  let currentCount = 0;

  var inc = function increment() {
    return currentCount++;
  };
  return inc;
})();

var incrementClicked = function () {
  var display = document.getElementById("closureValue");
  display.value = count();
};
