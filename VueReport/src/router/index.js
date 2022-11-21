import { createWebHistory, createRouter } from "vue-router";

import MainPage from '../pages/MainPage.vue'
import SecondPage from '../pages/SecondPage.vue'
import NotFound from '../pages/NotFound.vue'

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
    {
        path: "/:catchAll(.*)",
        component: NotFound,
    },
];

const router = createRouter({
    history: createWebHistory(),
    routes,
});

export default router;