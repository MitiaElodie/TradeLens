// src/router.ts
import { createRouter, createWebHistory, type RouteRecordRaw } from 'vue-router';
import TradeJournal from '@/views/TradeJournal.vue';

const routes: Array<RouteRecordRaw> = [
  {
    path: '/trade',
    name: 'TradeJournal',
    component: TradeJournal
  },
];

const router = createRouter({
  history: createWebHistory(),
  routes
});

export default router;
