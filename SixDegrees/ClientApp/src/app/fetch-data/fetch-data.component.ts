import { Component } from '@angular/core';
import { WeatherForecastClient, WeatherForecast } from '../api/SixDegreesApi.v1'; // eslint-disable-line no-unused-vars

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public forecasts: WeatherForecast[];

  constructor(weatherForecastClient: WeatherForecastClient) {
    weatherForecastClient.get().subscribe(result => {
      this.forecasts = result;
    }, error => console.error(error));
  }
}
