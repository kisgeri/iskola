let weather = {
    apiKey : "f63faa951285c3b123dac8111da71d58",
    fetchWeather: function (city) {
        fetch(
          "https://api.openweathermap.org/data/2.5/weather?q=" +
            city +
            "&units=metric&lang=hu&appid=" +
            this.apiKey
            
        )
          .then((response) => {
            if (!response.ok) {
              alert("No weather found.");
              throw new Error("No weather found.");
            }
            return response.json();
          })
          .then((data) => this.displayWeather(data));
      },
      displayWeather: function (data) {
        const { name } = data;
        const { icon, description } = data.weather[0];
        const { temp, humidity } = data.main;
        const { speed } = data.wind;
        document.querySelector(".weather_city").innerText = name;
        document.querySelector(".icon").src =
          "https://openweathermap.org/img/wn/" + icon + ".png";
        document.querySelector(".leiras").innerText = description;
        document.querySelector(".weather_temp").innerText = temp + "°C";
        document.querySelector(".paratartalom").innerText =
          "Páratartalom: " + humidity + "%";
        document.querySelector(".wind").innerText =
          "Szél sebesége: " + speed + " km/h";
        document.querySelector(".weather").classList.remove("loading");
        document.weather_card.style.backgroundImage =
          "url('https://source.unsplash.com/1600x900/?" + name + "')"; //random háter
      },
      search: function () {
        this.fetchWeather(document.querySelector(".search-bar").value);
      },
    };
    
    
    document.querySelector(".search button").addEventListener("click", function () {
      weather.search();
    });
    
    document
      .querySelector(".search-bar")
      .addEventListener("keyup", function (event) {
        if (event.key == "Enter") {
          weather.search();
        }
      });
    









  weather.fetchWeather("Budapest");