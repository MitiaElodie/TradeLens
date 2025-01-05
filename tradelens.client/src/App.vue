<script setup lang="ts">
import TheMenu from '@/components/TheMenu.vue'
</script>

<template>
  <v-app class="app__container">
    <TheMenu />
    <v-main class="app__content">
      <router-view />
    </v-main>
  </v-app>
</template>

<style lang="scss">
.app {
  &__container {
    display: flex;
    height: 100vh;
  }

  &__menu {
    width: var(--menu-width);
  }
}
</style>
