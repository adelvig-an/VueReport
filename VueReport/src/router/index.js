import { createWebHistory, createRouter } from "vue-router";

import MainPage from '../pages/MainPage.vue'
import SecondPage from '../pages/SecondPage.vue'

const routes = [
    {
        path: '/',
        name: 'MainPage',
        component: MainPage,
    },
    {
        path: '/second',
        name: 'SecondPage',
        component: SecondPage,
    },
];

const router = createRouter({
    history: createWebHistory(),
    routes,
});

export default router;