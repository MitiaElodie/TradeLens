<script lang="ts">
export default {
   name: 'TheMenu',
}
</script>

<template>
   <v-navigation-drawer>
      <v-list-item title="TradeLens"></v-list-item>
      <v-divider></v-divider>
      <v-list-item
         :to="{name: 'Home'}"
         title="Trade journal"
      ></v-list-item>
   </v-navigation-drawer>
</template>