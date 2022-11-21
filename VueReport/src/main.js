import { createApp } from 'vue'
import App from './App.vue'
import router from './router/index'


//Подключение bootstrap v5.2.2
import "bootstrap/dist/css/bootstrap.min.css"
import "bootstrap"

createApp(App).use(router).mount('#app')
