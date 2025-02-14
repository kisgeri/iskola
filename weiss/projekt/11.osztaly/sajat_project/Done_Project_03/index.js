function toggleColor() {
  const body = document.body;
  const themeCheckbox = document.querySelector('.theme-checkbox');

  // Toggle the background color
  if (themeCheckbox.checked) {
    body.style.backgroundColor = '#f3f3f3';
    document.getElementById("description").style.backgroundColor = '#626262';
    document.getElementById("box_data_01").style.backgroundColor = '#626262';
    document.getElementById("box_data_02").style.backgroundColor = '#626262';
    document.getElementById("box_data_03").style.backgroundColor = '#626262';
    document.getElementById("kepzes").style.backgroundColor = '#626262';
    document.getElementById("footer").style.backgroundColor = '#626262';
  } else {
    body.style.backgroundColor = 'rgba(35,35,35,1)';
    document.getElementById("description").style.backgroundColor = 'rgba(58,58,58,1)';
    document.getElementById("box_data_01").style.backgroundColor = 'rgba(58,58,58,1)';
    document.getElementById("box_data_02").style.backgroundColor = 'rgba(58,58,58,1)';
    document.getElementById("box_data_03").style.backgroundColor = 'rgba(58,58,58,1)';
    document.getElementById("kepzes").style.backgroundColor = 'rgba(58,58,58,1)';
    document.getElementById("footer").style.backgroundColor = 'rgba(58,58,58,1)';
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