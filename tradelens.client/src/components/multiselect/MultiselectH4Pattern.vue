<script lang="ts">
import { H4_PATTERN } from '@/constants.js';
export default {
   name: 'MultiselectH4Pattern',

   props: {
      value: {
         type: String,
         required: true,
      },
   },

   computed: {
      h4Patterns(): object[] {
         return Object.values(H4_PATTERN);
      },
   },
}
</script>
<template>
   <v-autocomplete
      label="H4 pattern"
      :items="h4Patterns"
      item-title="label"
   ></v-autocomplete>
</template>