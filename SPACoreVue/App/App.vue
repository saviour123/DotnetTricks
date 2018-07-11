<template>
    <div id='home'>
        <h1>Hello World</h1>
        <router-link to="todo">Todo List</router-link>
        <router-link to="forecast">Forecast List</router-link>
        <router-link to="quotes">Get Inspired</router-link>
        <router-view></router-view>
    </div>
</template>


<!-- scripts section --> 
<script>
export default { }
</script>

<!-- styles --> 
<style lang="scss">
    @import './variables.scss';

    #home {
        max-width: 400px;
        margin: 0 auto;
        line-height: 1.4;
        font-family: 'Avenir', Helvetica, Arial, sans-serif;
        -webkit-font-smoothing: antialiased;
        -moz-osx-font-smoothing: grayscale;
        color: $vue-green;
    }

    h1 {
        text-align: center;
    }
    // p {
    //     padding: 34em
    // }

</style>
