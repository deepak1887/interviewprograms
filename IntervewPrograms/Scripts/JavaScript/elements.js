const createRow = () => {
  const row = document.createElement("div");
  row.className = "row";
  return row;
};

const createColumn = (innetText) => {
  const col = document.createElement("div");
  col.className = "col";
  col.innerText = innetText;
  return col;
};

const createButton = (text) => {
  const btn = document.createElement("button");
  btn.innerText = text;
  btn.className = "btn btn-success";
  return btn;
};
export default { createRow, createColumn, createButton };
