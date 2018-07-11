<template>
    <div id="app">
        <button v-on:click="fetchForecasts">Get Data</button>
        <p> Status {{ info }}.</p>
        <ul>
            <li v-for="forecast in forecasts" v-bind:key="forecast.Id">
                {{ forecast.summary }}
            </li>
        </ul>
    </div>
</template>

<script>
import DataAPI from '../../Api/DataAPI.js'
import $ from 'jquery'

export default {
    data () {
        return {
            forecasts: [],
            error: null,
            info: "Not run yet"
        }
    },
    methods: {
        fetchForecasts() {
            this.info = "Fetching"
            DataAPI.getData()
            .then((data) =>{
                this.forecasts = data;
                this.info = "Done"
            })
        }
    }
}
</script>

<style lang="scss">

</style>
