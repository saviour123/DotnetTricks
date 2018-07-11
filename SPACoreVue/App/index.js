import Vue from 'vue'
import VueRoute from 'vue-router'
import App from './App.vue'
import VueRouter from 'vue-router'
import TodoList from './Components/Todo/TodoList.vue'
import ForecastList from './Components/ForecastList/ForecastList.vue'
import Quote from './Components/Inspire/Inspirations.vue'

Vue.config.productionTip = false
Vue.use(VueRouter)


const routes = [
    {
        path: '/',
        component: App,
        children: [
            {
                path: 'todo',
                component: TodoList
            },
            {
                path: 'forecast',
                component: ForecastList
            },
            {
                path: 'quotes',
                component: Quote
            }
        ]
    }
]

const router = new VueRouter({
    routes,
    mode: 'history'
})

new Vue({
    el: '#app',
    template: "<div><router-view></router-view></div>",
    router
})

