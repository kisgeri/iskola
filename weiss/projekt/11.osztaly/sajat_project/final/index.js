function toggleColor() {
  const body = document.body;
  const themeCheckbox = document.querySelector('.theme-checkbox');

  // Toggle the background color
  if (themeCheckbox.checked) {
    body.style.backgroundColor = 'white';
  } else {
    body.style.backgroundColor = 'rgba(35,35,35,1)';
  }
}

/*
document.addEventListener('DOMContentLoaded', function () {
    const lightThemeSelector = document.querySelector('.light-theme');
    const darkerThemeSelector = document.querySelector('.darker-theme');
    const body = document.body;

    lightThemeSelector.addEventListener('click', function () {
        body.classList.remove('dark-theme');
        body.classList.add('light-theme');
    });

    darkerThemeSelector.addEventListener('click', function () {
        body.classList.remove('light-theme');
        body.classList.add('dark-theme');
    });
});
*/
function refreshTime() {
    var datetime = new Date().toLocaleTimeString();
    console.log(datetime); // it will represent date in the console of developers tool
    document.getElementById("time").textContent = datetime; // represent on html page
}
    setInterval(refreshTime, 1000);