import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { SampleDataClient, WeatherForecast } from '../api/SixDegreesApi.v1';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public forecasts: WeatherForecast[];

  constructor(sampleDataClient: SampleDataClient) {
    sampleDataClient.weatherForecasts().subscribe(result => {
      this.forecasts = result;
    }, error => console.error(error));
  }
}
