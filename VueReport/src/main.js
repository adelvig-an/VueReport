import { createApp } from 'vue'
import App from './App.vue'
import router from './router/index'
import store from './store/index'
//import axios from './api/instans'


//Подключение bootstrap v5.2.2
import "bootstrap/dist/css/bootstrap.min.css"
import "bootstrap"

createApp(App).use(router, store, /*axios*/).mount('#app')
