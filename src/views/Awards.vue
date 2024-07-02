<template>
  <v-main class="peoplePage">
    <Awards :AwardData="AwardData" />
  </v-main>
</template>
<script>
import YAML from 'yamljs'
import Awards from '@/components/Awards.vue'
//
var nativeObject = YAML.load('./data/data.yml')
var jsonstr = JSON.stringify(nativeObject)
var jsondata = JSON.parse(jsonstr)

export default {
  components: {
    Awards
  },
  data: () => ({
    AwardData: jsondata.AwardData
  })
}
</script>
<style lang="css" scoped>
.peoplePage{
  max-width: 1185px;
  margin: auto;
}
</style>
