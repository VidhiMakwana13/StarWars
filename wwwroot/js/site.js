// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function showCharacterDetails(name, height, mass, birthYear, filmsCount) {
    document.getElementById('modal-title').innerText = name;
    document.getElementById('modal-height').innerText = height;
    document.getElementById('modal-mass').innerText = mass;
    document.getElementById('modal-date-added').innerText = new Date().toLocaleDateString('en-GB');
    document.getElementById('modal-films').innerText = filmsCount;
    document.getElementById('modal-birth-year').innerText = birthYear;
    document.getElementById('character-modal').style.display = 'block';
}

function closeModal() {
    document.getElementById('character-modal').style.display = 'none';
}
