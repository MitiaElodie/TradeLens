<script lang="ts">
import { DAILY_PATTERN } from '@/constants.js';
export default {
   name: 'MultiselectDailyPattern',

   computed: {
      dailyPatterns(): object[] {
         return Object.values(DAILY_PATTERN);
      },
   },
}
</script>
<template>
   <v-autocomplete
      label="Daily pattern"
      :items="dailyPatterns"
      item-title="label"
   ></v-autocomplete>
</template>