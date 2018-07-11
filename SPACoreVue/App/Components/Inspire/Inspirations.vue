<template>
    <app id="app">
        <button v-on:click="fetchQuote">Get Quote</button>
        <p>Status {{ info }}</p>
        <ul>
            hell
            <!-- {{ quotes.contents.quotes[0].quote }}  - {{ quotes.contents.quotes[0].author }} -->
        </ul>
    </app>
</template>

<script>
import DataApi from '../../Api/DataAPI.js'
import $ from 'jquery'

export default {
    data(){
        return {
            quotes: '',
            error: null,
            info: 'Nothing Yet'
        }
    },
    methods: {
        fetchQuote(){
            this.info = "fetching data",
            DataApi.fetchQuote()
            .then((resp) => {
                console.log(resp.contents.quotes[0])
                this.quotes = resp
                this.info = 'Inspiration for the Data'
            })
        }
    }
}
</script>

<style lang="scss">

</style>
