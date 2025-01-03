<script setup lang="ts">
import TheMenu from '@/components/TheMenu.vue'

</script>

<template>
  <div class="app__container">
    <aside class="app__menu">
      <TheMenu />
    </aside>
    <main class="app__content">
      <router-view />
    </main>
  </div>
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
