/**
 * https://codepen.io/retrofuturistic/pen/tlbHE
 * */

var selectedElem = null;

var cols = document.querySelectorAll('#columns .column');
[].forEach.call(cols, addDnDHandlers);

function handleDragStart(e) {
    
    selectedElem = this;
    e.dataTransfer.effectAllowed = 'move';
    e.dataTransfer.setData('text/html', this.outerHTML);
    this.classList.add('dragElem');
}

function handleDragOver(e) {
    if (e.preventDefault) {
        e.preventDefault();
    }
    this.classList.add('over');
    e.dataTransfer.dropEffect = 'move';
    return false;
}

function handleDragEnter(e) {

}

function handleDragEnd(e) {
    this.classList.remove('over');
}

function handleDragLeave(e) {
    this.classList.remove('over');
}

function handleDrop(e) {

    if (e.stopPropagation) {
        e.stopPropagation();
    }

    if (selectedElem != this) {

        this.parentNode.removeChild(selectedElem);
        var dropHTML = e.dataTransfer.getData('text/html');

        this.insertAdjacentHTML('beforebegin', dropHTML);
        var dropElem = this.previousSibling;

        addDnDHandlers(dropElem);
        console.log("Thats a drop");
        reOrder()
    }

    this.classList.remove('over');
    return false;
}

function addDnDHandlers(elem) {
    elem.addEventListener('dragstart', handleDragStart, false);
    elem.addEventListener('dragenter', handleDragEnter, false)
    elem.addEventListener('dragover', handleDragOver, false);
    elem.addEventListener('dragleave', handleDragLeave, false);
    elem.addEventListener('drop', handleDrop, false);
    elem.addEventListener('dragend', handleDragEnd, false);
}

function reOrder() {
    var x = document.getElementsByClassName('header-span');
    for (i = 0; i < x.length; i++) {
        var text = x[i].innerText;
        var idxOfDot = text.indexOf('.');
        text = i + 1 + "." + text.substr(idxOfDot + 1);
        x[i].innerText = text;
    }
}