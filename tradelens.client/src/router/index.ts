// src/router.ts
import { createRouter, createWebHistory, type RouteRecordRaw } from 'vue-router';
import TradeList from '@/views/TradeList.vue';

const routes: Array<RouteRecordRaw> = [
  {
    path: '/',
    name: 'Home',
    component: TradeList
  },
];

const router = createRouter({
  history: createWebHistory(),
  routes
});

export default router;
