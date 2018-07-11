import { get } from "http";

export default {
    getData: () => {
        return fetch('/api/Data/WeatherForecasts', {
            method: 'get'
        }).then(function (response) {
            return response.json();
        }).then(function (response){
            return response;
        })
    },
    fetchQuote: () => {
        return fetch('http://quotes.rest/qod.json?category=life', {
            method: 'get'
        }).then(function (response){
            return response.json();
        }).then(function (response) {
           return response;
        })
    }
} 